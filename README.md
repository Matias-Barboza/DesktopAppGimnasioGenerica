# Desktop App Gimnasio Genérica
Al tratarse de una copia del proyecto Desktop App Gimnasio, veremos que las bases son las mismas. Es decir, las operaciones que se pueden
realizar en la aplicación no varían demasiado pero sí implementan algunos cambios.

## Tecnologías utilizadas:
- .NET
- C#
- WinForms
- SQL Server

En este apartado el cambio mas sustancial es el uso de SQL Server, ya que la versión "original", lo planteé con MySQL.

## Vistas de la app

![imagen](https://github.com/Matias-Barboza/DesktopAppGimnasioGenerica/assets/111096363/a100d968-9158-4759-9dd4-c4c69f8b03e4)

- En el inicio del sistema, el cambio que conlleva son las notificaciones rápidas, una manera de obtener datos sin estar accediendo a ninguno
de los apartados en particular, dando al usuario un acercamiento al estado de los socios y sus cuotas.

</br>

- Cada una de las secciones, contiene un ToolTip que informa acerca de qué representa el número que ofrece.

![imagen](https://github.com/Matias-Barboza/DesktopAppGimnasioGenerica/assets/111096363/d9e730b0-9e50-44be-8ac4-e1cb9dc9c536)

![imagen](https://github.com/Matias-Barboza/DesktopAppGimnasioGenerica/assets/111096363/5b121c9d-00b0-460f-a769-cac36d5a1b70)

![imagen](https://github.com/Matias-Barboza/DesktopAppGimnasioGenerica/assets/111096363/399f4321-9e1d-4277-9553-45bf8d2e9f35)

</br>

- A la hora de registrar una nueva cuota, a modo de proporcionar mayor información y exactitud, cada vez que se cambie el número
de socio al que se está intentando asociar una cuota, se muestra la coincidencia encontrada con algún nombre en base al número de
socio (de existir).

![imagen](https://github.com/Matias-Barboza/DesktopAppGimnasioGenerica/assets/111096363/5ede8f01-ae9e-4202-a693-61adf576427f)

- En este caso, al existir la coincidencia, se muestra el nombre del socio al que se asociaría la cuota.

![imagen](https://github.com/Matias-Barboza/DesktopAppGimnasioGenerica/assets/111096363/5c0220ae-e81e-485f-846f-c928b91de151)

- Ya que no existe coincidencia para este caso, se avisa con el mensaje en el TextBox.

![imagen](https://github.com/Matias-Barboza/DesktopAppGimnasioGenerica/assets/111096363/3a817fb8-613b-49e9-b0a7-6e08b60fc7a9)

- Al borrarse el texto, se limpia el TextBox.



