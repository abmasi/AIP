using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.DATA.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {

            }

            isDisposed = true;
        }

        protected virtual void DisposeCore()
        {

        }

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
