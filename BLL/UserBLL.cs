using BLL.Checkers;
using Cmm;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL : BaseValidator<User>
    {
        private UserDAO userDAO = new UserDAO();
        public Response Insert(User item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                return userDAO.Insert(item);
            }
            return response;
        }
        public override Response Validate(User item)
        {
            if (CheckAnyProperty.IsAnyNullOrEmpty(item))
            {
                AddError("Todos os campos do endereco devem ser informados");
            }
            foreach (string err in CheckAttributeLength.AttributeLength<User>(item))
            {
                AddError(err);
            }
            AddError(item.Cpf.IsValidCPF());
            AddError(item.Email.IsValidEmail());
            return base.Validate(item);
        }
    }
}
