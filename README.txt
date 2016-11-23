Przed uruchomieniem aplkacji nale¿y zainicjalizowaæ bazê dancyh pozycjami z menu.

W tym celu nale¿y ustawiæ projekt RestaurantOrder.ConsoleApp jako startowy i go uruchomiæ. 

Po inicjalizacji danymi ustawiamy projekt RestaurantOrder.GUI jako startowy i uruchamiamy aplikacjê.

UWAGA: Przed wys³aniem zamówneia nale¿y skonfiguraowaæ ustawienia emaila. Konfiguracja zapisana jest w pliki App.config w projekcie RestaurantOrder.GUI.

<add key="EmailUserName" value="email@example.com"/>
<add key="EmailUserNameTo" value="email@example.com"/>
<add key="EmailPassword" value="EmailPassword"/>
<add key="EmailHost" value="EmailHost"/>
<add key="EmailPort" value="5000"/>
<add key="EmailTimeout" value="5000"/>

Domyœlnie, w celu nieprawid³owego przetworzenia zamównia kod wysy³aj¹cy maila z zamówieniem jest zakomentowany. Linia 157 projektu RestaurantOrder.GUI.RestaurantOrderForm.cs. 



