using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftos.Business.Exceptions
{
    public class ImageFileException : Exception
    {
        public ImageFileException(string? message) : base(message)
        {
        }
    }
}
