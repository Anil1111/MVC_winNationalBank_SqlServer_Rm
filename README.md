# MVC_winapp_ComboBox_selector

### Project : prjWin_MVC_ComboBox_selector_Rm

Building a CRUD (create, read, update, delete) code with the MVC (model, view, controller) philosophy in  C # .NET Focusing in the selector ComboBox control

Fall-2018

The objective : Implementing Basic CRUD Functionality.

## Getting Started

This project focus in the MVC philosophy.

![MVC](/img/MVCmodel.JPG "MVC")

[Understanding MVC architecture](https://www.youtube.com/watch?v=eTdVkgF_Slo)

[SQL Server connection](https://www.youtube.com/watch?v=OdDkFPO_nto)

[CRUD with MVC](https://www.youtube.com/watch?v=_H8vswpMSOw&t=650s)

[Install SQL Server](https://www.microsoft.com/en-ca/sql-server/sql-server-downloads)

[Install Visual Studio](https://visualstudio.microsoft.com/)

[Dowland the MVC_ComboBox_selector project](https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector)


### Create the database with SQl server. 

1.- Open SQL Server Management Studio, open a new query and run Init_DataBase.sql

[MVC_winapp_ComboBox_selector/sql/Init_DataBase.sql](https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector/blob/master/sql/Init_DataBase.sql)

2.- Fill up the tables, run dataTables.sql

[MVC_winapp_ComboBox_selector/sql/dataTables.sql](https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector/blob/master/sql/Init_DataBase.sql)

3.- The class clsConnection connects the SQL Server and the Visual Studio

```
static private string stringConnection = "Data Source = .; DataBase = bd_aspcrud_examen; Integrated Security = true";
```

### Prerequisites

 * Visual Studio.
 * Object-oriented programming.
 * Programming language : C#.
 * SQL server Management Studio.
 * Programming language SQL.
 * MVC.

## Running the tests

Inteface loads the grid when it starts.

![INIT](/img/init.jpg "Init")

We can select a client by combo box Employee or combo box Agencies.

![Select by Employee or Agency](/img/select.jpg "Select by employee or agency")

We can select a row and loads the texts boxes then we can update a clietn.

![Select By Row](/img/byRow.jpg "Select by row")

Save and update are executed with the same button.


## Built With

* [SQL Server](https://www.microsoft.com/en-ca/sql-server/sql-server-downloads) - SQL Server
* [Visual Studio](https://visualstudio.microsoft.com/) - Visual Studio

## Author

* **Ricardo Mendoza -  Programmer Analyst**

## Versions and source manager. 

This project uses GitHub.com as source manager in the following repository:

https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector.git


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

- Copyright Ricardo Mendoza
- the MIT License (MIT)

## Acknowledgments

* Andy Del Risco - MENTOR, *Technicien Informatique Cl. Principale* [École des métiers de l’aérospatiale de Montréal](http://ecole-metiers-aerospatiale.csdm.ca/)
* Jesvin Ciril Joachim - MVC
* RJ Code Advance - CRUD
* Derek Banas - SQL Server and Visual Studio Installation
* [Institut Teccart](http://www.teccart.qc.ca/)







