using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.S.Example2
{
    public class Image
    { }
    public class Account
    { }
    public class Url
    { }
    public static class ImageHelper
    {
        public static void Save(Image image)
        {
            // сохранение изображение в файловой системе
        }

        public static int DeleteDuplicates()
        {
            // удалить из файловой системы все дублирующиеся изображения и вернуть количество удаленных
            return 0;
        }

        public static Image SetImageAsAccountPicture(Image image, Account account)
        {
            // запрос к базе данных для сохранения ссылки на это изображение для пользователя
            return image;
        }

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

        public static byte[] Download(Url imageUrl)
        {
            // загрузка битового массива с изображением с помощью HTTP запроса
            return new byte[3];
        }

        // и т.п.
    }
}
