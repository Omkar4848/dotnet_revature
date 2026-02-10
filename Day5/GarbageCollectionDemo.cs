using System;

class Room : IDisposable
{
    private bool disposed = false;
    public void Dispose()
    {
        Dispose(true);                    
        GC.SuppressFinalize(this);        
    }

   
    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            return;

        if (disposing)
        {
            
            Console.WriteLine("Managed resources cleaned");
        }

        Console.WriteLine("Unmanaged resources cleaned");

        disposed = true;
    }

    ~Room()
    {
        Dispose(false);
    }
}
