using MyBlog.Entities.ComplexTypes;
using MyBlog.Entities.Dtos.ImageDtos;
using MyBlog.Shared.Utilities.Results;

namespace MyBlog.Mvc.Halpers.Abstract
{
    /// <summary>
    /// name dosya ismi belirlemede kullanılır.
    /// Folder Name, Default olarak null değer alır. Eğer değer atanmazsa default user rresmi kullanılır
    /// </summary>
    /// <param name="name">Dosya ismi belirlemede kullanılır.</param>
    /// <param name="pictureFile">Yüklenecek resim dosyası</param>
    /// <param name="pictureType"></param>
    /// <param name="folderName">Default olarak null değer alır. Eğer değer atanmazsa default user rresmi kullanılır</param>
    /// <returns></returns>
    public interface IImageHelper
    {

        Task<IDataResult<ImageUploadedDto>> Upload(string name, IFormFile pictureFile,PictureType pictureType, string folderName=null);
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
