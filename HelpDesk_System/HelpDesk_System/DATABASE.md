# Database Schema Documentation (Part 1)

## 1. Departments
- Primary Key: Id (INTEGER)
- Columns: Name (TEXT), Description (TEXT, Nullable), IsActive (INTEGER)
- Relationships: Has many Employees, Has many Teams

## 2. Employees
- Primary Key: Id (INTEGER)
- Foreign Key: DepartmentId -> Departments(Id)
- Columns: FirstName (TEXT), LastName (TEXT), Email (TEXT), JobTitle (TEXT), HireDate (TEXT), IsActive (INTEGER)
- Relationships: Belongs to Department, Has many TeamMembers, TicketAssignments, TicketComments

## 3. Teams
- Primary Key: Id (INTEGER)
- Foreign Key: DepartmentId -> Departments(Id)
- Columns: Name (TEXT), Description (TEXT, Nullable)
- Relationships: Belongs to Department, Has many TeamMembers

## 4. TeamMembers
- Composite Primary Key: (TeamId, EmployeeId)
- Foreign Keys: TeamId -> Teams(Id), EmployeeId -> Employees(Id)
- Columns: JoinedAt (TEXT)

## 5. Customers
- Primary Key: Id (INTEGER)
- Columns: CompanyName (TEXT), ContactName (TEXT), Email (TEXT), Phone (TEXT, Nullable), CreatedAt (TEXT), IsActive (INTEGER)
- Relationships: Has many Tickets