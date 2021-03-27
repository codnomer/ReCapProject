using Business.Abstract;
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

        public List<Color> GetAll()
        {
            return _ıcolor.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _ıcolor.Get(c=>c.ColorId==colorId);
        }
    }
}
