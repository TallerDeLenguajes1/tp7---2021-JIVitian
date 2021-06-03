# tp7---2021-JIVitian
tp7---2021-JIVitian created by GitHub Classroom  
Alumno: Vitian, Jorge Iván

## Septimo Trabajo Práctico de Taller de Lenguajes 1 de Licenciautra Informatica - PU. FACET-UNT

### Respuestas a las preguntas del TP:
- ***a) Objetos del tipo LinkedList y List, ¿Cuales son las diferencias que tienen?***
	- Clase List<T>  
	Representa una lista de objetos fuertemente tipados a la que se puede obtener acceso por índice. Proporciona métodos para buscar, ordenar y manipular listas. T representa el tipo de elementos de la lista y puede ser tanto una clase como variables primitivas.
	- Clase LinkedList<T>  
	Representa una lista doblemente enlazada. T representa el tipo de elementos de la lista y puede ser tanto una clase como variables primitivas. Cada nodo de la lista apunta tanto al Siguiente (Next) como al Anterior (Previous).
	- La diferencia entre estas dos clases es que, por un lado List se comporta de una manera muy similar a lo que son los Arreglos, manejandose con indices. En cambio en la clase LinkedList, solo tenemos acceso directo al primer y ultimo nodo de la lista, y para encontrar el resto debemos recorrer uno por uno cada nodo.
- ***b) Objeto Diccionario.***
	**Dictionary<TKey,TValue>**  
	El objeto Diccionario es una colección de datos que contiene una serie de valores, cada uno asociados cada uno a una clave.   
	**TKey:** Tipo de las claves del diccionario.
	**TValue:** Tipo de los valores del diccionario.
- ***c) Beneficios de usar una biblioteca, por que pondria una clase en una biblioteca y cuando agregaria
directamente la clase en su proyecto***  
	- Usar bibliotecas facilita al programador funciones que vienen implementadas en la misma, esto hace que no tenga que codificar desde 0 las mismas y solo tenga que preocuparse por usarlas para hacer funcional el programa que esté realizando. Ésto agiliza mucho el proceso de desarrollo de un proyecto y, en general, las bibliiotecas estan diseñadas de forma eficiente y con buenas prácticas de desarrollo.
	- Pondría una clase en una biblioteca cuando crea que pueda usar la misma en varios proyectos, de modo que no tenga que programarla cada vez que la use. En cambio, agregaría directamente la clase al proyecto cuando necesite que la clase tenga un comportamiento algo distinto al que especifiqué en la biblioteca y resultase mas fácil hacerla de 0 que adaptar la misma al proyecto.
- ***d) Como se agrega la referencia a una biblioteca de clase en su proyecto***
	Para agregar una referencia a una biblioteca en un proyecto en Visual Studio, debemos hacer clic derecho en el nodo *Referencias* o *Dependencias* del explorador de soluciones y elegir la opción *Agregar Referencia*. O bien, poddemos hacer clic derecho en el nodo del proyecto y seleccionar *Agregar* > *Referencia*.