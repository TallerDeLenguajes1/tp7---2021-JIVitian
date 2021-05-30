# tp6---2021-JIVitian
tp6---2021-JIVitian created by GitHub Classroom
Alumno: Vitian, Jorge Iván

## Quinto Trabajo Práctico de Taller de Lenguajes 1 de Licenciautra Informatica - PU. FACET-UNT

### Respuestas a las preguntas del TP:
* ***¿Qué es la propiedad TabIndex? ¿Para qué se utiliza?***  
	- Según la documentación oficial, la propiedad TabIndex obtiene o establece un valor entero que determina el orden en el que los elementos reciben el foco cuando el usuario navega por los controles utilizando la tecla TAB.  
	- Se utiliza para determinar el orden de navegación lógico en un dispositivo.  
* ***¿Cómo funciona el foco en un control en particular?***  
	- En cada componente que quisieramos que tenga un TabIndex le asignamos un valor, cada vez que el usuairo presione la tecla TAB, irá haciendo foco a cada componente con la propiedad, comenzando por el que tenga el valor mas pequeño hasta el que tenga el mayor valor. Si recorre todos los componentes indexados, éste recorrido se repetirá desde el inicio.  
* ***¿Qué son los eventos? ¿Cómo se utilizan los eventos del teclado?***  
	- Según la documentación, los eventos permiten que una clase u objeto notifique a otras clases u objetos cuando ocurre algo de interés. La clase que envía (o genera) el evento se llama editor y las clases que reciben (o manejan) el evento se llaman suscriptores.Es decir, in evento es un mensaje que es enviado por un objeto para indicar que cierta acción va a ocurrir.
	- Los eventos de teclado son sucesos cuyo disparador es presionar una tecla en especifico. Cuando un usuario presiona una tecla, Windows Forms determina qué evento se genera en función de si el mensaje del teclado especifica una tecla de carácter o una tecla física. Windows Forms proporciona dos eventos que se producen cuando el usuario presiona una tecla del teclado y un evento cuando el usuario suelta una tecla del teclado: 
		- El evento KeyDown, que se produce una vez.
		- El evento KeyPress, que se puede producir varias veces cuando un usuario mantiene presionada la misma tecla.
		- El evento KeyUp se produce una vez cuando el usuario suelta una tecla.