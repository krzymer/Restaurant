Przed uruchomieniem aplkacji należy zainicjalizować bazę dancyh pozycjami z menu.

W tym celu należy ustawić projekt RestaurantOrder.ConsoleApp jako startowy i go uruchomić. 

Po inicjalizacji danymi ustawiamy projekt RestaurantOrder.GUI jako startowy i uruchamiamy aplikację.

UWAGA: Przed wysłaniem zamówneia należy skonfiguraować ustawienia emaila. Konfiguracja zapisana jest w pliki App.config w projekcie RestaurantOrder.GUI.

<add key="EmailUserName" value="email@example.com"/>
<add key="EmailUserNameTo" value="email@example.com"/>
<add key="EmailPassword" value="EmailPassword"/>
<add key="EmailHost" value="EmailHost"/>
<add key="EmailPort" value="5000"/>
<add key="EmailTimeout" value="5000"/>

Domyślnie, w celu nieprawidłowego przetworzenia zamównia kod wysyłający maila z zamówieniem jest zakomentowany. Linia 157 projektu RestaurantOrder.GUI.RestaurantOrderForm.cs. 



