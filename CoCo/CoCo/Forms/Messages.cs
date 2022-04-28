using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class Messages : UserControl
    {
        public static bool ConfirmDelete()
        {
            if (MessageBox.Show(
                "Вы уверены, что хатите удалить этот элемент?",
                "Удаление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                ) == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void TooLong(string what)
        {
            MessageBox.Show(
                    what + " слишком длинное",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        public static void WrongFormat(string what)
        {
            MessageBox.Show(
                    what + " содержит не поддерживаемый формат",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        public static void ServerError()
        {
            MessageBox.Show(
                    "Ошибка соединения с сервером",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        public static void Empty()
        {
            MessageBox.Show(
                    "Заполните все поля",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
    }
}
