using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DimselabUniversalApp.Annotations;

namespace DimselabUniversalApp
{
    class Member
    {
        private string _memberName;
        private string _class;

        public Member(string memberName, string @class)
        {
            _memberName = memberName;
            _class = @class;
        }

        public string MemberName
        {
            get { return _memberName; }
            set
            {
                _memberName = value; 
            }
        }

        public string Class
        {
            get { return _class; }
            set
            {
                _class = value;
            }
        }
        public override string ToString()
        {
            return "Member name: " + _memberName + "\tMember class: " + _class.ToString();
        }
    }
}
