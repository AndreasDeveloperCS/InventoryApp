InventoryApp 

![image](https://github.com/AndreasDeveloperCS/InventoryApp/assets/38625058/6812edb8-38d4-4537-8f9d-69ac8ca5ad48)

Simple demo solution implemented using WPF and C#/.NET 6 with simple logic and DataTemplates


Architecturally solution is devided to 6 separate projects with aim of simplify maintainance and following low coupling approach:


Inventory.Core - General Core domain classes and interfaces


Inventory.UI.Core - General Styles, Converters and Behaviors that are enriching the usability and UI/UX


Inventory.Data - Project responsible for data layer and sources of data, that could be extended with different adapters


Inventory.CustomControls - Controls that could be reused in other applications of infrastructure related with similar style and functionality


Inventory.UserControls - UserControls Blocks that could be reused in other applications of infrastructure related with similar style and functionality 


InventoryApp - Main Application with integrated functionality 

![image](https://github.com/AndreasDeveloperCS/InventoryApp/assets/38625058/486eb20a-7a46-448f-b495-4fa07df28140)
