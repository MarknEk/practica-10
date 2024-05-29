using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_10
{
    public partial class Form1 : Form
    {
        private Programmer programmer;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ваш код инициализации формы, если это необходимо
        }

        public Form1()
        {
            InitializeComponent();
            InitializeProgrammer();
            FillLists();
        }
        private void FillLists()
        {
            // Добавление элементов в список программиста
            programmer.Add("Code 1");
            programmer.Add("Code 2");

            // Обновление состояния списков на форме
            UpdateLists();
        }

        // Обновление состояния списков на форме
        private void UpdateLists()
        {
            listBoxProgrammer.Items.Clear();

            // Получение текущего состояния списка программиста
            List<string> programmerList = programmer.GetList();

            // Отображение элементов в списке программиста на форме
            foreach (string item in programmerList)
            {
                listBoxProgrammer.Items.Add(item);
            }
        }
        private void InitializeProgrammer()
        {
            // Создание объекта программиста
            programmer = new Programmer();

            // Подписка на события
            programmer.Delete += Programmer_Delete;
            programmer.Mutate += Programmer_Mutate;

            // Добавление элементов в список программиста
            programmer.Add("Code 1");
            programmer.Add("Code 2");
        }

        // Обработчик события удаления
        private void Programmer_Delete(object sender, EventArgs e)
        {
            MessageBox.Show("Программист удалил элемент.");
            UpdateLists(); // Обновление состояния списка программиста на форме
        }

        // Обработчик события мутации
        private void Programmer_Mutate(object sender, EventArgs e)
        {
            MessageBox.Show("Программист изменил список.");
            UpdateLists(); // Обновление состояния списка программиста на форме
        }

        // Обработчик кнопки "Удалить первый элемент"
        private void btnDeleteFirst_Click(object sender, EventArgs e)
        {
            programmer.DeleteFirst();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            programmer.Reset(); // Вызываем метод сброса состояния списка программиста
            UpdateLists(); // Обновляем отображение списка на форме
        }
        // Обработчик кнопки "Удалить последний элемент"
        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            programmer.DeleteLast();
        }

        // Обработчик кнопки "Мутация списка"
        private void btnMutate_Click(object sender, EventArgs e)
        {
            programmer.MutateList();
        }
    }

    // Класс программиста
    public class Programmer
    {

        // Событие удаления
        public event EventHandler Delete;

        // Событие мутации
        public event EventHandler Mutate;

        private List<string> list;

        public Programmer()
        {
            list = new List<string>();
        }
        // Метод для сброса состояния списка программиста к исходному
        public void Reset()
        {
            list.Clear(); // Очищаем список программиста
            Add("Code 1"); // Добавляем исходные элементы
            Add("Code 2");
        }

        // Добавление элемента в список
        public void Add(string item)
        {
            list.Add(item);
        }

        // Удаление первого элемента
        public void DeleteFirst()
        {
            if (list.Count > 0)
            {
                list.RemoveAt(0);
                OnDelete(EventArgs.Empty);
            }
        }

        // Удаление последнего элемента
        public void DeleteLast()
        {
            if (list.Count > 0)
            {
                list.RemoveAt(list.Count - 1);
                OnDelete(EventArgs.Empty);
            }
        }

        // Мутация списка
        public void MutateList()
        {
            // Реализация мутации может быть любой
            // Например, перемешивание элементов
            list.Reverse();
            OnMutate(EventArgs.Empty);
        }

        protected virtual void OnDelete(EventArgs e)
        {
            Delete?.Invoke(this, e);
        }

        protected virtual void OnMutate(EventArgs e)
        {
            Mutate?.Invoke(this, e);
        }

        // Получение текущего состояния списка
        public List<string> GetList()
        {
            return list;
        }
    }
}
