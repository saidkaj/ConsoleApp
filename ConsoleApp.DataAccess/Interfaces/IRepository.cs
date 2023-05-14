using System;
using ConsoleApp.Core.Interfaces;

namespace ConsoleApp.DataAccess.Interfaces
{
	public interface IRepository<T> where T : IEntity
	{
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);


		T? Get(int id);

		List<T> GetAll();

		T? GetByName(string name);

		List<T> GetAllByName(string name);


	}
}

