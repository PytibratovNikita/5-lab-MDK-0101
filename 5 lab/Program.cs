using PhoneRepositoryMDK;
using PhoneRepositoryMDK;
using System.Numerics;


PhoneRepository repository = new PhoneRepository();

// Добавление автомобилей
repository.Insert(new Phone { Id = 1, Модель = "Iphone", Год = 2022, Цвет = "Белый" });
repository.Insert(new Phone { Id = 2, Модель = "Xiaomi", Год = 2020, Цвет = "Черный" });
repository.Insert(new Phone { Id = 3, Модель = "Realme", Год = 2021, Цвет = "Синий" });

// Получение всех автомобилей
List<Phone> allPhone = repository.GetAll();
Console.WriteLine("Все телефоны:");
foreach (Phone phone in allPhone)
{
    Console.WriteLine($"Id: {phone.Id},Модель : {phone.Модель}, Год: {phone.Год}, Цвет: {phone.Цвет}");
}
// Обновление телефона
Phone updatedPhone = new Phone { Модель = "Samsung", Год = 2021, Цвет = "Красный" };
repository.Update(2, updatedPhone);
Phone phoneAfterUpdate = repository.GetById(2);
Console.WriteLine("Обновить телефон по Id 2:");
Console.WriteLine($"Модель : {phoneAfterUpdate.Модель}, Год: {phoneAfterUpdate.Год}, Цвет: {phoneAfterUpdate.Цвет}");

// Удаление телефона
Console.WriteLine("Удаляем автомобиль под Id 2.....");
repository.Delete(2);
Console.WriteLine("Спсиок авто после удаления Id 1:");
foreach (Phone phone in allPhone)
{
    Console.WriteLine($"Id: {phone.Id},Модель : {phone.Модель}, Год: {phone.Год}, Цвет: {phone.Цвет}");
}

// Получение телефона по номеру(ID)
Phone phoneById = repository.GetById(3);
Console.WriteLine("Телефон под  Id 3:");
Console.WriteLine($"Модель : {phoneById.Модель}, Год: {phoneById.Год}, Цвет: {phoneById.Цвет}");