
![image](https://github.com/AndreasDeveloperCS/InventoryApp/assets/38625058/5e2c7c1b-0501-4b5d-931f-b4c43c5c616d)

InventoryApp 

Small demo solution implemented on WPF with simple logic and DataTemplates


Architecturally solution is devided to 6 separate projects with aim of simplify maintainance and following low coupling approach:


Inventory.Core - General Core domain classes and interfaces


Inventory.UI.Core - General Styles, Converters and Behaviors that are enriching the usability and UI/UX


Inventory.Data - Project responsible for data layer and sources of data, that could be extended with different adapters


Inventory.CustomControls - Controls that could be reused in other applications of infrastructure related with similar style and functionality


Inventory.UserControls - UserControls Blocks that could be reused in other applications of infrastructure related with similar style and functionality 


InventoryApp - Main Application with integrated functionality regarding  

![image](https://github.com/AndreasDeveloperCS/InventoryApp/assets/38625058/486eb20a-7a46-448f-b495-4fa07df28140)
