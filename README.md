# Steam Web - быстрая работа с внутренним API Steam
SteamWeb предназначен для выполнения запрос в Steam. Запросы выполняются с использованием библиотеки [RestSharp](https://github.com/restsharp/RestSharp) что делает мультипоточностью очень быстрой.

На данный момент имеются следующие функции:
- Авторизация через [protobuf](https://github.com/protobuf-net/protobuf-net)
- Загрузка инвентаря
- Реализованы API для работа с маркетом, с данными аккаунтов (чтение и изменение любых данных), с магазином steam
- Своя реализация Proxy
- Реализованы запросы на страницу поддержки стим - это даёт возможность сделать изменение пароля, почты и телефона
- Есть возможность использовать публичное API Steam (реализованы не все методы)

Мелкие особенности:
- Удобное хранение данных сессии (включая платформу, для которой происходила авторизация)
- Цифры хранятся не в строках
- Правильное хранение данных maFile (мой вариант называется smaFile)
- Реализован класс для быстрого получения `item_nameid`
- Доступна быстрая авторизация через вызов одной функции
- Реализованы все методы, нужные для трейдинга
- Доступны все методы для выставления на продажу предметов
- Для точного парсинга, в некоторых методах, реализован парсер html [AngleSharp](https://github.com/AngleSharp/AngleSharp), для более точного получения нужных данных
