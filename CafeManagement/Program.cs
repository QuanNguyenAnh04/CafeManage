using CafeManagement.Forms;
using CafeManagement.Models;

namespace CafeManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MyApplicationContext());
        }
    }

    // ApplicationContext để quản lý nhiều form
    public class MyApplicationContext : ApplicationContext
    {
        public MyApplicationContext()
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            LoginForm loginForm = new LoginForm();

            // Khi đăng nhập thành công
            loginForm.LoginSuccess += OnLoginSuccess;

            // Nếu người dùng đóng LoginForm mà chưa login → thoát app
            bool loginSucceeded = false;
            loginForm.LoginSuccess += (account) => loginSucceeded = true;

            loginForm.FormClosed += (s, e) =>
            {
                if (!loginSucceeded)
                    ExitThread();
            };

            loginForm.Show();
        }

        private void OnLoginSuccess(Account account)
        {
            Dashboard dashboard = new Dashboard(account);

            // Khi Dashboard đóng → thoát app
            dashboard.FormClosed += (s, e) => ExitThread();

            dashboard.Show();
        }
    }

}