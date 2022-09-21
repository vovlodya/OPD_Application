using PDBEF;

namespace OPD_Application.Repositories
{
    interface IRepository<T> : IDisposable
            where T : class
    {
        IEnumerable<T> GetModels(); // получение всех объектов
        T GetModel(int id); // получение одного объекта по id

        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений

    }
}
