using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdom.Core.ViewModels
{
    public abstract class BaseViewModel<TParameter> : BaseViewModel, IMvxViewModel<TParameter>
        where TParameter : notnull
    {
        public abstract void Prepare(TParameter parameter);
    }
}
