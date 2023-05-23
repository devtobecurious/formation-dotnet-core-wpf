using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HaryPotterWpf.Win.UI.Core
{
    public class BaseBindable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged<T>(Expression<Func<T>> expression)
        {
            var body = expression.Body;

            if (body != null && body is MemberExpression member && member.Member is PropertyInfo info)
            {
                this.PropertyChanged?.Invoke(this, new(info.Name));
            }
        }
    }
}
