namespace Domain.Errors;

public static class DomainErrors
{
    public static class Order
    {
        public static string NotFound => "Заказ не найден";
        public static string EmptyNumber => "Номер заказа не может быть пустым";
        public static string MultiIndexNotUnique => "Невозможно создать несколько заказов от одного поставщика с одинаковым номером";
    }
    public static class OrderItem
    {
        public static string EmptyName => "Наименование элемента заказа не может быть пустым";
        public static string EmptyUnit => "Подразделение элемента заказа не может быть пустым";
        public static string NegativeQuantity => "Количество элемента заказа не может быть отрицательным";
    }
    public static class Provider
    {
        public static string NotFound => "Поставщик не найден";
    }
}
