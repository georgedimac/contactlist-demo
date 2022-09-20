
# Contact List Demo
Uses Angular on frontend and gets the contacts via an REST-API from the c# .net backend

Built on: Angular CLI: 14.2.1 ; Node: 16.17.0 ; .net 6

It showcases Angular Dialog when clicking on a contact, outputs his address there.

## API Reference
GET /contacts

| Parameter | Type     | 
| :-------- | :------- | 
| `Name` | `string` | 
| `Address` | `string` | 

## Run

```bash
  cd ang-test
  dotnet run
```
Uses SPA Proxy , http://localhost:7777 , redirecting to https://localhost:44450/ after the Angular frontend is compiled+started in the background, the backend runs on http://localhost:5153

## Testing

Includes NUnit Tests

```bash
  cd back-tests
  dotnet test
```
