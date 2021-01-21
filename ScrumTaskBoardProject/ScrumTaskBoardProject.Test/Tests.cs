using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrumTaskBoard.DataAccess.Concrete.Repositories;

namespace ScrumTaskBoardProject.Test
{
    [TestClass]
    public class Tests
    {
        /* Bu test methodumuzda database kısmında 3 tane proje var iken 
        veritabanından GetirHepsi() methodunun doğru sonuç verip vermediğine vardık. */
        [TestMethod]
        public void GetirTumProjeler()
        {
            ProjeRepository projeler = new ProjeRepository();

            var result = projeler.GetirHepsi();

            Assert.AreEqual(6, result.Count);
        }

        /* Bu test methodumuzda database kısmında Id'si 26 olan proje olmadığında
          null geleceğini test ettik. */
        [TestMethod]
        public void GetirProjeById()
        {
            ProjeRepository proje = new ProjeRepository();

            var result = proje.GetirIdile(26);

            Assert.IsNull(result);
        }

        /* Bu test mehodumuzda User tablosunda 3 numaralı Id'e sahip 
          User'ın gelip gelmediğini kontrol ettik*/
        [TestMethod]
        public void GetirUserById()
        {
            bool sonuc;


            UserRepository user = new UserRepository();

            var result = user.GetirIdile(3);
            if(result!=null)
            {
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }

            Assert.IsTrue(sonuc);
        }
        
        /*Bu test methodumuzda Task tablosu ile User tablosunu join ettiğimiz methodun içerisine
         Id değeri atıp değerin null olup olmadığını kontrol ettik*/
        [TestMethod]
        public void GetirTaskWithUsersById()
        {
            bool sonuc;
            TaskRepository task = new TaskRepository();

            var result = task.GetirUsersById(3);

            if (result != null)
            {
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }

            Assert.IsTrue(sonuc);
        }

        /*Bu test methodunda User tablosunda 2 numaralı Id'ye sahip kullanıcının Name
         özelliğinin doğru gelip gelmediğini kontrol ettik.*/
        [TestMethod]
        public void GetirUserByName()
        {
            string name = "Onurcan";
            UserRepository user = new UserRepository();

            var result = user.GetirByFilter(x=>x.Id==2);

            
            Assert.AreEqual(name,result.Name);
        }
    }
}
