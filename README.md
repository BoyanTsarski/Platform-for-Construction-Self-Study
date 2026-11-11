# Платформа за строителен самоучител

Уеб приложение за самостоятелно обучение по строителство за начинаещи и любители. Дипломен проект на Боян Юлианов Царски, 12А клас, ПГДН „СофтУни БУДИТЕЛ“, гр. София.

> Проектът е в начален етап на разработка.

## Предназначение и цел
Платформата предоставя организирани учебни материали и практически инструкции и позволява проследяване на обучението на потребителите.

## Използвани технологии
- C# и ASP.NET Core MVC с Razor (.NET 10)
- Entity Framework Core (Code First, миграции, seeding)
- MS SQL Server (LocalDB за разработка)
- ASP.NET Core Identity (роли и оторизация)
- HTML5, CSS3, JavaScript, Bootstrap
- xUnit (тестове)
- Git и GitHub

## Структура на решението
- `ConstructionSelfStudy.Web` - MVC слой (контролери, изгледи)
- `ConstructionSelfStudy.Services` - бизнес логика
- `ConstructionSelfStudy.Data` - модели и достъп до базата
- `ConstructionSelfStudy.Tests` - тестове

## Инструкции за стартиране
1. Инсталирайте .NET 10 SDK и SQL Server (или LocalDB).
2. Клонирайте хранилището:
   ```
   git clone https://github.com/BoyanTsarski/Platform-for-Construction-Self-Study.git
   ```
3. Задайте низа за връзка към базата в User Secrets:
   ```
   dotnet user-secrets init --project ConstructionSelfStudy.Web
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=(localdb)\MSSQLLocalDB;Database=ConstructionSelfStudy;Trusted_Connection=True;TrustServerCertificate=True" --project ConstructionSelfStudy.Web
   ```
4. Създайте базата с миграциите:
   ```
   dotnet ef database update --project ConstructionSelfStudy.Data --startup-project ConstructionSelfStudy.Web
   ```
5. Стартирайте приложението:
   ```
   dotnet run --project ConstructionSelfStudy.Web
   ```

## Структура на базата данни
Основни таблици: `Categories`, `Courses`, `Lessons`, `LessonSteps`, `LessonProgresses`, `SavedLessons`, както и таблиците на ASP.NET Core Identity.

## Роли
- **Learner (Обучаем)** - разглежда и търси уроци, следи напредъка си, запазва уроци.
- **Author (Автор)** - създава курсове, уроци и практически инструкции.
- **Administrator (Администратор)** - одобрява съдържанието и управлява потребители и категории.

Демонстрационни акаунти за всяка роля ще бъдат добавени при публикуването на приложението.

## Планирани функционалности
- Регистрация, вход и профили
- Каталог с курсове и уроци по категории, с търсене
- Практически инструкции стъпка по стъпка, с материали и инструменти
- Проследяване на преминатите уроци и запазване на избрани уроци
- Одобряване на съдържанието от администратор
- Адаптивен интерфейс с валидация

## Автор
Боян Юлианов Царски
