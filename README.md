# InterviewChallenge
Interview Challenge

## Task Description

**Problem Description**:

You are responsible for developing an API to manage a hotel room booking system. The API should allow the following operations:

1. **Create a booking**.
2. **Retrieve booking details**.
3. **Retrieve bookings between a couple of dates**.
3. **Update a booking**.
4. **Cancel a booking**.

**Technical Requirements**:

1. **C# and ASP.NET Core**:
   - Use C# and the ASP.NET Core framework to create the API.

2. **Automated Testing**:
   - Implement unit tests using xUnit to verify the functionality of the API.

3. **SOLID Principles**:
   - Ensure your code follows the SOLID principles to guarantee maintainability and scalability.

## Specific Details

**Booking Model**:
```csharp
public class Booking
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public string RoomType { get; set; }
    public bool IsCancelled { get; set; }
}
```

## Aditional Tips
**Endpoints**:

1. **Create Booking**:
   - **Endpoint**: `POST /api/bookings`
   - **Request Body**:
     ```json
     {
       "customerName": "John Doe",
       "checkInDate": "2023-06-01",
       "checkOutDate": "2023-06-07",
       "roomType": "Deluxe"
     }
     ```

2. **Retrieve Booking Details**:
   - **Endpoint**: `GET /api/bookings/{id}`

3. **Retrieve bookings between a couple of dates**:
   - **Endpoint**: `GET /api/bookings/{startDate}/{endDate}`

4. **Update Booking**:
   - **Endpoint**: `PUT /api/bookings/{id}`
   - **Request Body**:
     ```json
     {
       "customerName": "Jane Doe",
       "checkInDate": "2023-06-10",
       "checkOutDate": "2023-06-15",
       "roomType": "Suite"
     }
     ```

5. **Cancel Booking**:
   - **Endpoint**: `DELETE /api/bookings/{id}`