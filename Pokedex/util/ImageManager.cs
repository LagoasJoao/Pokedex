using System;
using System.Drawing;
using System.IO;

namespace Pokedex
{
    public class ImageManager
    {
        /// <summary>
        /// Converte um BLOB (array de bytes) em um objeto Image.
        /// </summary>
        /// <param name="imageBlob">O BLOB que representa a imagem.</param>
        /// <returns>Um objeto Image criado a partir do BLOB.</returns>
        public static Image BlobToImage(byte[] imageBlob)
        {
            if (imageBlob == null || imageBlob.Length == 0)
            {
                throw new ArgumentException("O BLOB de imagem não pode ser nulo ou vazio.", nameof(imageBlob));
            }

            using (MemoryStream ms = new MemoryStream(imageBlob))
            {
                return Image.FromStream(ms);
            }
        }

        /// <summary>
        /// Converte um objeto Image em um BLOB (array de bytes).
        /// </summary>
        /// <param name="image">O objeto Image a ser convertido.</param>
        /// <returns>Um array de bytes representando o BLOB da imagem.</returns>
        public static byte[] ImageToBlob(Image image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "A imagem não pode ser nula.");
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
