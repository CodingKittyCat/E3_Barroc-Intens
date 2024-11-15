# E3_Barroc-Intens

## 0. Project Structure
**Project**
    - **Assets**
        - *All the assets used within the application.*
    - **Data**
        - **Classes**
            - *All the entity classes.*
        - **Lists**
            - *Preset lists for database seeding.*
        - **AppDbContext**
            - *The application's data context.*
    - **fonts**
        - *Fonts used within the application.*
    - **Migrations**
        - *Migrations used for the database.*
    - **Modules**
        - *Modules created for use within the application.*

## 1. Naming Conventions
- **Classes**: Use PascalCase (e.g., `MainWindow`, `CustomerViewModel`).
- **Properties and Methods**: Use PascalCase for public properties and methods (e.g., `FirstName`, `CalculateTotal`).
- **Fields**: Use camelCase or an underscore prefix (`_`) for private fields (e.g., `_isRunning`, `isInitialized`).
- **Events**: Use the past tense with PascalCase for event names (e.g., `DataLoaded`, `ButtonClicked`).
- **XAML Elements**: Name UI elements consistently, using PascalCase and adding their type (e.g., `SubmitButton`, `UserNameTextBox`).

## 2. Binding and Data Context
- Use `{Binding PropertyName}` for binding syntax.
- For complex bindings, specify paths and converters explicitly.
- Set the `DataContext` in XAML rather than in code-behind whenever possible.

## 3. Formatting
- **XAML**:
  - Indent elements consistently, with each nested element on a new line.
  - Place each attribute on a new line if there are multiple attributes for an element.
  - Align attributes for readability, maintaining a hierarchy in the XAML structure.
- **C# Code**:
  - Use tabs for indentation
  - Keep method lengths short and follow the single responsibility principle.

## 4. Code-Behind Best Practices
- Avoid placing heavy logic in code-behind files to maintain the MVVM architecture. Instead, use ViewModel classes.
- Use `partial` classes in C# to separate auto-generated designer code from your own code-behind logic.

## 5. Properties and Dependency Properties
- Use dependency properties in XAML for data-binding instead of regular properties.
- Implement `INotifyPropertyChanged` for ViewModel properties to allow the UI to update automatically.

## 6. Commands
- Use `ICommand` implementations, such as `RelayCommand` or `DelegateCommand`, for UI commands in the ViewModel.
