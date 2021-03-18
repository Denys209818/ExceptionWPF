using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ExceptionWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        ///     Перевантажений метод DispatcherUnhandledException, який відловлює усі помилки,
        ///     відловлювання яких було відсутнє в коді. 
        /// </summary>
        /// <param name="sender">Обєкт який згенерував подію</param>
        /// <param name="e">Параметри помилки</param>
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //  Присвоєння помилки до нової змінної
            Exception ex = e.Exception;
            //  Виведення вікна, яке сповіщає про помилку в коді
            MessageBox.Show("An unhandled exception just occurred: " 
                + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            //  Параметр Handled повідомляє програмі що помилку вже оброблено і програмі не потрібно
            //  її додатково обролювати
            e.Handled = true;
        }
    }
}
