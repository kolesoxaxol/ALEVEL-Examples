using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.S.Example2
{
    public static class ImageFileManager
    {
        public static void Save(Image image)
        {
            // сохранение изображение в файловой системе
        }

        public static int DeleteDuplicates()
        {
            return 0;
            // удалить из файловой системы все дублирующиеся изображения и вернуть количество удаленных
        }
    }

    public static class ImageRepository
    {
        public static Image SetImageAsAccountPicture(Image image, Account account)
        {
            // запрос к базе данных для сохранения ссылки на это изображение для пользователя
            return image;
        }
    }

    public static class Graphics
    {

        public static Image Resize(Image image, int height, int width)
        {
            // изменение размеров изображения
            return image;
        }

        public static Image InvertColors(Image image)
        {
            // изменить цвета на изображении
            return image;
        }
    }

    public static class ImageHttpManager
    {
        public static byte[] Download(Url imageUrl)
        {
            // загрузка битового массива с изображением с помощью HTTP запроса
            return new byte[3];
        }
    }
}
