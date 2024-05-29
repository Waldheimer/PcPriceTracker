# Boilerplate Code for WPF MVVM Application with

### CommunityToolkit for MVVM and the Hosting Extension from Microsoft

## Nuget Packages

- [x] CommunityToolkit.Mvvm
- [x] Microsoft.Extensions.Hosting

## Setup and Boilerplate Code

1. Remove **StartupUri** from App.xaml
2. Create Basic Folderstructure
   - [x] Views
   - [x] Components
   - [x] ViewModels
   - [x] Models
   - [x] HostBuilder
   - [x] Manager
   - [x] Services
   - [x] Messages
   - [x] Styles
   - [x] Converter
3. Move MainWindow to Views
4. Create **MainWindowViewModel** in ViewModels and inherit from **ObservableReceipient**
5. Setup **WindowsHost** and **MainWindow** in **App.xaml.cs**
6. Setup **NavigationService\<TViewModel\>** for Handling Navigation
7. Setup **NavigationManager** for Managing the NavigationState
8. Setup the **HostBuilderExtensions** for DI-Registrations
