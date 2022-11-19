using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITodoService
    {
        IDataResult<List<Todo>> GetAll();
        IResult Add(Todo todo);
        IResult Update(Todo todo);
    }
}
