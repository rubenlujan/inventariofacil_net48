using InventarioFacil.DAL.DBServices;
using InventarioFacil.DAL.DBServices.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.Domain
{
    public class UserModel
    {
        private int _id;
        private string _username;
        private string _password;
        private string _name;
        private string _email;
        private int _userrol_id;
        private string _userrol_dsc;
        private int _isActive;
        private UserDA _userDal;

        public UserModel()
        {
            _userDal = new UserDA();
        }

        public UserModel Login(string username, string password)
        {
            var result = _userDal.Login(username, password);
            if (result != null)
                return MapUserModel(result);
            else
                return null;
        }

        private UserModel MapUserModel(User userEntity)
        {
            var userModel = new UserModel()
            {
                Id = userEntity.UserId,
                Username = userEntity.Username,
                Password = userEntity.Password,
                Name = userEntity.CompleteName,
                Email = userEntity.Email,
            };
            return userModel;
        }

        #region "Propiedades"

        [DisplayName("Id")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Usuario")]//Nombre a visualizar.
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de usuario debe contener un mínimo de 5 caracteres.")]
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        [DisplayName("Contraseña")]
        [Browsable(false)]
        [Required(ErrorMessage = "Por favor ingrese una contraseña.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "La contraseña debe contener un mínimo de 5 caracteres.")]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        [DisplayName("Nombre Completo")]
        [Browsable(false)]
        [Required(ErrorMessage = "Por favor ingrese nombre")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe contener un mínimo de 10 caracteres.")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Por favor ingrese correo electrónico.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido: example@gmail.com")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DisplayName("Tipo Usuario Id")]
        [Required(ErrorMessage = "Por favor ingrese el rol del usuario.")]
        public int UserRol_Id
        {
            get { return _userrol_id; }
            set { _userrol_id = value; }
        }

        [DisplayName("Tipo Usuario Dsc")]
        public string UserRol_Dsc
        {
            get { return _userrol_dsc; }
            set { _userrol_dsc = value; }
        }

        [DisplayName("Activo")]
        public int IsActvie
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        #endregion

    }
}
