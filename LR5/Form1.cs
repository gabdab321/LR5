using System.Text;

namespace LR5
{
   public interface IPrototype
    {
        IPrototype Clone();
    }

    public partial class Form1 : Form
    {
        private readonly IBurgerBuilder _builder = new ConcreteBurgerBuilder();
        private readonly BurgerDirector _director;

        public Form1()
        {
            InitializeComponent();
            _director = new BurgerDirector(_builder);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClassicBurger_Click_1(object sender, EventArgs e)
        {
            _director.BuildClassicBurger();
            var burger = _builder.GetBurger();
            txtBurgerDetails.Text = burger.ToString();
        }

        private void btnChickenBurger_Click_1(object sender, EventArgs e)
        {
            _director.BuildChickenBurger();
            var burger = _builder.GetBurger();
            txtBurgerDetails.Text = burger.ToString();
        }

        private void btnCloneBurger_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це просте системне повідомлення");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloneBurger_Click_1(object sender, EventArgs e)
        {
            // Отримання поточного бургера
            var burger = _builder.GetBurger();

            // Клонування бургера
            var clonedBurger = burger.Clone() as Burger;

            // Виведення інформації про оригінальний бургер в перший TextBox
            txtBurgerDetails.Text = burger.ToString();

            // Додавання інформації про клонований бургер в другий TextBox
            txtClonedBurgers.AppendText(clonedBurger.ToString() + Environment.NewLine);
        }
    }

    // Клас для представлення бургера
    public class Burger : IPrototype
    {
        public string Bun { get; set; }
        public string Meat { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();
        public string Sauce { get; set; }

        public IPrototype Clone()
        {
            // Створюємо новий об'єкт та копіюємо властивості
            var clonedBurger = (Burger)this.MemberwiseClone();
            clonedBurger.Toppings = new List<string>(this.Toppings); // Копіюємо список топінгів, щоб уникнути спільного використання списку
            return clonedBurger;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Bun: {Bun}");
            builder.AppendLine($"Meat: {Meat}");
            builder.AppendLine($"Sauce: {Sauce}");
            builder.AppendLine("Toppings: " + string.Join(", ", Toppings));
            return builder.ToString();
        }
    }

    // Інтерфейс для будівельника бургера
    public interface IBurgerBuilder
    {
        void SetBun(string bun);
        void SetMeat(string meat);
        void AddTopping(string topping);
        void SetSauce(string sauce);
        Burger GetBurger();
    }

    // Конкретний будівельник
    public class ConcreteBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger();

        public void SetBun(string bun) => _burger.Bun = bun;
        public void SetMeat(string meat) => _burger.Meat = meat;
        public void AddTopping(string topping) => _burger.Toppings.Add(topping);
        public void SetSauce(string sauce) => _burger.Sauce = sauce;
        public Burger GetBurger()
        {
            var result = _burger;
            _burger = new Burger(); // Перезапуск для нового бургера
            return result;
        }
    }

    // Директор
    public class BurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildClassicBurger()
        {
            _builder.SetBun("Sesame Bun");
            _builder.SetMeat("Beef Patty");
            _builder.AddTopping("Lettuce");
            _builder.AddTopping("Tomato");
            _builder.SetSauce("Ketchup");
        }

        public void BuildChickenBurger()
        {
            _builder.SetBun("Plain Bun");
            _builder.SetMeat("Chicken Patty");
            _builder.AddTopping("Pickles");
            _builder.AddTopping("Cheese");
            _builder.SetSauce("Mayo");
        }
    }
}
