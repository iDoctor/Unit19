using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit19.BLL.Exceptions;
using Unit19.BLL.Models;
using Unit19.PLL.Helpers;

namespace Unit19.PLL.Views
{
    public class FriendAddingView
    {
        public void Show(User user)
        {
            var messageSendingData = new MessageSendingData();

            Console.Write("Введите почтовый адрес пользователя, которого вы хотите добавить в список друзей: ");
            messageSendingData.RecipientEmail = Console.ReadLine();

            try
            {
                // TODO: Добавить логику
                SuccessMessage.Show("Пользователь успешно добавлен в список друзей!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении пользователя в список друзей!");
            }

        }
    }
}
