using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoard.DataAccess.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Concrete
{
    public class UserManager: IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Ekle(User entity)
        {
            _userDal.Ekle(entity);
        }

        public User GetirAdIle(string userName)
        {
            return _userDal.GetirByFilter(x => x.Name == userName);
        }

        public List<User> GetirHepsi()
        {
            return _userDal.GetirHepsi();
        }

        public User GetirIdile(int id)
        {
            return _userDal.GetirIdile(id);
        }

        public void Guncelle(User entity)
        {
            _userDal.Guncelle(entity);
        }

        public void Sil(User entity)
        {
            _userDal.Sil(entity);
        }
    }
}
