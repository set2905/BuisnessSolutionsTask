namespace Domain.Errors;

public static class DomainErrors
{
    public static class Order
    {
        public static string NotFound => "Заказ не найден";
        public static string EmptyNumber => "Номер заказа не может быть пустым";
        public static string NumberEqualsToItemName => "Номер заказа не может совпадать с  именем любого из его элементов";
        public static string MultiIndexNotUnique => "Невозможно создать несколько заказов от одного поставщика с одинаковым номером";
        public static string IdNull => "Id заказа не может быть пустым";
        public static string IncorrectDateSpan => "Дата начала выборки не может быть позже даты конца выборки";
    }
    public static class OrderItem
    {
        public static string NotFound => "Элемент заказа не найден";
        public static string EmptyName => "Наименование элемента заказа не может быть пустым";
        public static string EmptyUnit => "Подразделение элемента заказа не может быть пустым";
        public static string NegativeQuantity => "Количество элемента заказа не может быть отрицательным";
    }
    public static class Provider
    {
        public static string NotFound => "Поставщик не найден";
    }

    public static class Paging
    {
        public static string PageLessThanOne => "Страница не может быть меньше 1";
    }
}
