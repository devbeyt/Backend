using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TodoManager : ITodoService
    {
        ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public IResult Add(Todo todo)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Todo>> GetAll()
        {
            return new SuccessDataResult<List<Todo>>(_todoDal.GetAll());
        }

        public IResult Update(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
