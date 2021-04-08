using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConserns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _ıcolor;

        public ColorManager(IColorDal ıcolor)
        {
            _ıcolor = ıcolor;
        }

        public IResult Add(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);
            _ıcolor.Add(color);
            return new SuccessResult(Messages.ColorAddMessage);
        }

        public IResult Delete(Color color)
        {
            _ıcolor.Delete(color);
            return new SuccessResult(Messages.ColorDeleteMessage);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_ıcolor.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_ıcolor.Get(c => c.ColorId == colorId));
        }

        public IResult Uptade(Color color)
        {
            return new SuccessResult(Messages.ColorUptateMessage);
        }
    }
}
