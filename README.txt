Przed uruchomieniem aplkacji nale�y zainicjalizowa� baz� dancyh pozycjami z menu.

W tym celu nale�y ustawi� projekt RestaurantOrder.ConsoleApp jako startowy i go uruchomi�. 

Po inicjalizacji danymi ustawiamy projekt RestaurantOrder.GUI jako startowy i uruchamiamy aplikacj�.

UWAGA: Przed wys�aniem zam�wneia nale�y skonfiguraowa� ustawienia emaila. Konfiguracja zapisana jest w pliki App.config w projekcie RestaurantOrder.GUI.

<add key="EmailUserName" value="email@example.com"/>
<add key="EmailUserNameTo" value="email@example.com"/>
<add key="EmailPassword" value="EmailPassword"/>
<add key="EmailHost" value="EmailHost"/>
<add key="EmailPort" value="5000"/>
<add key="EmailTimeout" value="5000"/>

Domy�lnie, w celu nieprawid�owego przetworzenia zam�wnia kod wysy�aj�cy maila z zam�wieniem jest zakomentowany. Linia 157 projektu RestaurantOrder.GUI.RestaurantOrderForm.cs. 



