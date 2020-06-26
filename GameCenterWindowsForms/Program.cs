using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCenterWindowsForms
{
    public static class Program
    {
        public static
            int intDropStatis = 0;
        public static int IDSotr;
        public static int IDKlient;
        public static string baseDir = @"C:\Users\Kornoos Vildberg\Desktop\";

        public static ModelKlient modelKlient;

        //Проверка стутуса учётной записи бан или небан
        public static string intID = "",
            //Первичный ключ для работы с сессией пользователя
            strStatus = "Null";
        //Определяет принцип запуска интерфейса Klient или Employee
        public static bool connect = false;
        //Определяет есть подключение к БД или нет
        private static Mutex _instanse;
        //Класс создания виртуального процесса приложения
        private const string _app_Name = "Игровой центр";

        public static Int32 Dostup;
        //Название приложения
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Переменная переключатель для определения запуска приложения
            bool Create_app;
            //Объявление экземпляра класса нового виртуцального процесса
            _instanse = new Mutex(true, _app_Name, out Create_app);
            if (Create_app)
            {
                try
                {
                    //В случае если процесс не найден в системе
                    //создаётся экземпляр класса конфигурации подключения
                    //к источнику данных
                    Configuration_class configuration
                        = new Configuration_class();
                    //Вызывается метод получения информации из реестра
                    configuration.SQL_Server_Configuration_Get();
                    //Попытка открыть поддключение к источнику данных
                    Configuration_class.connection.Open();
                    //В случае если подключение открыто 
                    //в переменую присваевается значение истины
                    connect = true;
                }
                catch
                {
                    //Стилистика элементов уаправления ОС
                    Application.EnableVisualStyles();
                    //Обязательная дрянь, хер поймиёшь зачем она нужна
                    Application.SetCompatibleTextRenderingDefault(false);
                    //---НЕ СОЗДАНО--Объявление экземпляра класса
                    //конфигурации полдключения к источнику данных
                    Connection_Form connection = new Connection_Form();
                    //---НЕ СОЗДАНО---Вывод окна подключения к источнику данных
                    //В режиме диалогового окна
                    connection.ShowDialog();
                }
                finally
                {
                    Configuration_class.connection.Close();
                    switch (connect)
                    {
                        case false:
                            MessageBox.Show("Ошибка подключения " +
                                "к источнику данных!",
                                "Покупка билета",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            Environment.Exit(0);
                            break;
                        case true:
                            try
                            {
                                Application.EnableVisualStyles();
                                Application.SetCompatibleTextRenderingDefault(false);
                                Application.Run(new Authorization());
                                //Application.Run(new Connection_Form());
                            }
                            catch
                            {

                            }
                            break;
                    }
                }
            }
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
