using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.MessageToDeveloperDtos;
using MyBlog.Services.Abstract;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Results;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Entities.Dtos.AppointmentTypeDtos;

namespace MyBlog.Services.Concrete
{
    public class MessageToDeveloperManager:ManagerBase,IMessageToDeveloperService
    {
        private readonly MyBlogContext _dbContext;

        public MessageToDeveloperManager(MyBlogContext dbContext, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<MessageToDeveloperDto>> GetAsync(int MessageToDeveloperId)
        {
            var MessageToDeveloper = await UnitOfWork.MessageToDevelopers.GetAsync(c => c.Id == MessageToDeveloperId);
            if (MessageToDeveloper != null)
            {
                return new DataResult<MessageToDeveloperDto>(ResultStatus.Success, new MessageToDeveloperDto
                {
                    MessageToDeveloper = MessageToDeveloper,
                });
            }
            return new DataResult<MessageToDeveloperDto>(ResultStatus.Error, new MessageToDeveloperDto
            {
                MessageToDeveloper = null,
            }, Messages.General.NotFound(isPlural: false, "Geliştiriciye Mesaj"));
        }
        public async Task<IDataResult<MessageToDeveloperListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var customers = await UnitOfWork.MessageToDevelopers.GetAllAsync(x => !x.IsDeleted);
            if (customers.Count > -1)
            {
                return new DataResult<MessageToDeveloperListDto>(ResultStatus.Success, new MessageToDeveloperListDto
                {
                    MessageToDevelopers = customers,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<MessageToDeveloperListDto>(ResultStatus.Error, null, Messages.General.NotFound(false, "Geliştiriciye Mesaj"));

        }
        public async Task<IDataResult<MessageToDeveloperUpdateDto>> GetMessageToDeveloperUpdateDtoAsync(int MessageToDeveloperId)
        {
            var result = await UnitOfWork.MessageToDevelopers.AnyAsync(c => c.Id == MessageToDeveloperId);
            if (result)
            {
                var MessageToDeveloper = await UnitOfWork.MessageToDevelopers.GetAsync(c => c.Id == MessageToDeveloperId);
                var MessageToDeveloperUpdateDto = Mapper.Map<MessageToDeveloperUpdateDto>(MessageToDeveloper);
                return new DataResult<MessageToDeveloperUpdateDto>(ResultStatus.Success, MessageToDeveloperUpdateDto);
            }
            else
            {
                return new DataResult<MessageToDeveloperUpdateDto>(ResultStatus.Error, null, Messages.General.NotFound(isPlural: false, "Geliştiriciye Mesaj"));
            }
        }

        public async Task<IDataResult<MessageToDeveloperListDto>> GetAllAsync()
        {
            var MessageToDevelopers = await UnitOfWork.MessageToDevelopers.GetAllAsync(null);
            if (MessageToDevelopers.Count > -1)
            {
                return new DataResult<MessageToDeveloperListDto>(ResultStatus.Success, new MessageToDeveloperListDto
                {
                    MessageToDevelopers = MessageToDevelopers,
                });
            }
            return new DataResult<MessageToDeveloperListDto>(ResultStatus.Error, new MessageToDeveloperListDto
            {
                MessageToDevelopers = null,
            }, Messages.General.NotFound(isPlural: true, "Geliştiriciye Mesaj"));
        }
        public async Task<IDataResult<MessageToDeveloperDto>> AddAsync(MessageToDeveloperAddDto MessageToDeveloperAddDto, string createdByName)
        {
            var messageToDeveloper = Mapper.Map<MessageToDeveloper>(MessageToDeveloperAddDto);
            messageToDeveloper.CreatedDate = DateTime.Now;
            messageToDeveloper.ModifiedDate = DateTime.Now;
            messageToDeveloper.ModifiedByName = createdByName;
            messageToDeveloper.CreatedByName = createdByName;
            var addedMessageToDeveloper = await UnitOfWork.MessageToDevelopers.AddAsync(messageToDeveloper);
            await UnitOfWork.SaveAsync();
            //EntityEntry enrty = _dbContext.Entry(messageToDeveloper);
            //Console.WriteLine($"entity State: {enrty}");
            return new DataResult<MessageToDeveloperDto>(ResultStatus.Success, new MessageToDeveloperDto
            {
                MessageToDeveloper = addedMessageToDeveloper,
                Message= Messages.General.GiveMessage(addedMessageToDeveloper.CreatedByName, "Geliştiriciye Mesaj", MessagesConstants.AddSuccess)
            }, Messages.General.GiveMessage(addedMessageToDeveloper.CreatedByName, "Geliştiriciye Mesaj", MessagesConstants.AddSuccess));
        }

        public async Task<IDataResult<MessageToDeveloperDto>> UpdateAsync(MessageToDeveloperUpdateDto MessageToDeveloperUpdateDto, string modifiedByName)
        {
            var oldMessageToDeveloper = await UnitOfWork.MessageToDevelopers.GetAsync(c => c.Id == MessageToDeveloperUpdateDto.Id);
            var messageToDeveloper = Mapper.Map<MessageToDeveloperUpdateDto, MessageToDeveloper>(MessageToDeveloperUpdateDto, oldMessageToDeveloper);
            messageToDeveloper.ModifiedByName = modifiedByName;
            var updatedMessageToDeveloper = await UnitOfWork.MessageToDevelopers.UpdateAsync(messageToDeveloper);
            messageToDeveloper = await UnitOfWork.MessageToDevelopers.GetAsync(a => a.Id == MessageToDeveloperUpdateDto.Id);
            await UnitOfWork.SaveAsync();
            return new DataResult<MessageToDeveloperDto>(ResultStatus.Success, new MessageToDeveloperDto
            {
                Message= Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", MessagesConstants.UpdateSuccess),
                MessageToDeveloper = updatedMessageToDeveloper,
                ResultStatus = ResultStatus.Success,
            }, Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", MessagesConstants.UpdateSuccess));
        }
        public async Task<IDataResult<MessageToDeveloperDto>> DeleteAsync(int MessageToDeveloperId, string modifiedByName)
        {
            var messageToDeveloper = await UnitOfWork.MessageToDevelopers.GetAsync(c => c.Id == MessageToDeveloperId);
            if (messageToDeveloper != null)
            {
                messageToDeveloper.IsDeleted = true;
                //messageToDeveloper.IsActive = false;
                messageToDeveloper.ModifiedByName = modifiedByName;
                messageToDeveloper.ModifiedDate = DateTime.Now;
                var deletedEmployeeType = await UnitOfWork.MessageToDevelopers.UpdateAsync(messageToDeveloper);
                await UnitOfWork.SaveAsync();
                return new DataResult<MessageToDeveloperDto>(ResultStatus.Success, new MessageToDeveloperDto
                {
                    MessageToDeveloper = deletedEmployeeType,
                    Message= Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", MessagesConstants.UpdateSuccess)

                }, Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", MessagesConstants.UpdateSuccess));
            }
            return new DataResult<MessageToDeveloperDto>(ResultStatus.Error, new MessageToDeveloperDto
            {
                MessageToDeveloper = null,
            }, Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", "Güncellenemedi."));
        }
        public async Task<IDataResult<MessageToDeveloperListDto>> GetAllByDeletedAsync()
        {
            var messageToDevelopers = await UnitOfWork.MessageToDevelopers.GetAllAsync(c => c.IsDeleted);
            if (messageToDevelopers.Count > -1)
            {
                return new DataResult<MessageToDeveloperListDto>(ResultStatus.Success, new MessageToDeveloperListDto
                {
                    MessageToDevelopers = messageToDevelopers,
                });
            }
            return new DataResult<MessageToDeveloperListDto>(ResultStatus.Error, new MessageToDeveloperListDto
            {
                MessageToDevelopers = null,
            }, Messages.General.TableNotFound("Geliştiriciye Mesajlar"));
        }
        public async Task<IResult> HardDeleteAsync(int MessageToDeveloperId)
        {
            var messageToDeveloper = await UnitOfWork.MessageToDevelopers.GetAsync(c => c.Id == MessageToDeveloperId);
            if (messageToDeveloper != null)
            {
                await UnitOfWork.MessageToDevelopers.DeleteAsync(messageToDeveloper);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", MessagesConstants.HardDeletedSuccess));
            }
            return new Result(ResultStatus.Error, Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", MessagesConstants.HardDeletedSuccess));
        }


        public async Task<IDataResult<MessageToDeveloperDto>> UndoDeleteAsync(int MessageToDeveloperId, string modifiedByName)
        {
            var messageToDeveloper = await UnitOfWork.MessageToDevelopers.GetAsync(c => c.Id == MessageToDeveloperId);
            if (messageToDeveloper != null)
            {
                messageToDeveloper.IsDeleted = false;
                messageToDeveloper.IsActive = true;
                messageToDeveloper.ModifiedByName = modifiedByName;
                messageToDeveloper.ModifiedDate = DateTime.Now;
                var deletedMessageToDeveloper = await UnitOfWork.MessageToDevelopers.UpdateAsync(messageToDeveloper);
                await UnitOfWork.SaveAsync();
                return new DataResult<MessageToDeveloperDto>(ResultStatus.Success, new MessageToDeveloperDto
                {
                    Message = Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", MessagesConstants.UndoDeletedSuccess),
                    MessageToDeveloper = deletedMessageToDeveloper,
                }, Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", MessagesConstants.UndoDeletedSuccess));
            }
            return new DataResult<MessageToDeveloperDto>(ResultStatus.Error, new MessageToDeveloperDto
            {
                MessageToDeveloper = null,
            }, Messages.General.GiveMessage(messageToDeveloper.Title, "Geliştiriciye Mesaj", MessagesConstants.UndoDeletedError));
        }
        public async Task<IDataResult<int>> CountAsync()
        {
            var MessageToDevelopersCount = await UnitOfWork.MessageToDevelopers.CountAsync();
            if (MessageToDevelopersCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, MessageToDevelopersCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var MessageToDevelopersCount = await UnitOfWork.MessageToDevelopers.CountAsync(c => !c.IsDeleted);
            if (MessageToDevelopersCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, MessageToDevelopersCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, -1, $"Beklenmeyen bir hata ile karşılaşıldı.");
            }
        }
    }
}
