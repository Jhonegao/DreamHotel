using Cmm;
using Cmm.Auxiliar;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    
    public class AddressBLL : BaseValidator<Address>
    {
        private AddressDAO addressDAO = new AddressDAO();
        public Response Insert(Address item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                return addressDAO.Insert(item);
            }
            return response;
        }
        public Response Update(Address item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                return addressDAO.Update(item);
            }
            return response;
        }
        public override Response Validate(Address item)
        {

            if (IsAnyPropertyNull.IsAnyNullOrEmpty(item))
            {
                AddError("Todos os campos do endereco devem ser informados");
            }
            foreach (string err in CheckAttributeLength.AttributeLength<Address>(item))
            {
                AddError(err);
            }
            return base.Validate(item);
        }
    }
}
