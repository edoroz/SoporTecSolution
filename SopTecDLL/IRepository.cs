
using System.Collections.Generic;

namespace SopTecDLL
{
    public interface IRepository<T> {
        // Create
        T Create(T t);

        // Read One
        T Read(int id);

        // Read All
        List<T> Read();

        // Update
        T Update(T t);

        // Delete
        bool Delete(int id);
    } // -itf
} // -nsp
