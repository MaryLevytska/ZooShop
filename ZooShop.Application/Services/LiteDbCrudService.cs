using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LiteDB;

namespace Proc.Application.Services.Conversations.Cosmos.MessageFilters
{
    public sealed class LiteDbCrudService : IDisposable
    {

        private const string _dbName = "../../../../DB/animals.db";

        public LiteDbCrudService(IServiceProvider serviceProvider)
        {

            //CleanUp();
        }

        public void AddRange<T>(IEnumerable<T> list)
        {
            using var _db = new LiteDatabase(_dbName);

            var collection = _db.GetCollection<T>(typeof(T).Name);
            collection.InsertBulk(list);
        }

        public void Add<T>(T item)
        {
            using var _db = new LiteDatabase(_dbName);


            var collection = _db.GetCollection<T>(typeof(T).Name);
            collection.Insert(item);
        }

        public List<T> GetAll<T>()
        {
            using var _db = new LiteDatabase(_dbName);
            var collection = _db.GetCollection<T>(typeof(T).Name);

            return collection.FindAll().ToList();
        }

        public T Get<T>(BsonValue id)
        {
            using var _db = new LiteDatabase(_dbName);
            var collection = _db.GetCollection<T>(typeof(T).Name);

            return collection.FindById(id);
        }

        public void Delete<T>(BsonValue id)
        {
            using var _db = new LiteDatabase(_dbName);
            var collection = _db.GetCollection<T>(typeof(T).Name);

             collection.Delete(id);
        }

        public bool Exists<T>(Expression<Func<T, bool>> predicate)
        {
            using var _db = new LiteDatabase(_dbName);
            var collection = _db.GetCollection<T>(typeof(T).Name);

            return collection.Exists(predicate);
        }

        public void CleanUp()
        {
            using var _db = new LiteDatabase(_dbName);
            foreach (var item in _db.GetCollectionNames())
            {

                _db.DropCollection(item);
            }
        }

        public void Dispose()
        {
            CleanUp();

            GC.SuppressFinalize(this);
        }
    }
}