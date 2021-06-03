<h1>Users Table</h1>
<a href="/users/create">Create</a>
<table border="1" cellpadding="5" cellspacing="2">
  <thead>
    <tr>
      <th>Name</th>
      <th>Username</th>
      <th>Email</th>
      <th>Password</th>
      <th>Phone Number</th>
      <th>Gender</th>
      <th>Image URL</th>
      <th>Action</th>
    </tr>
  </thead>
  <tbody>
    @foreach($users as $user)
    <tr>
      <td>{{$user->name}}</td>
      <td>{{$user->username }}</td>
      <td>{{$user->email}}</td>
      <td>{{$user->password}}</td>
      <td>{{$user->phone_number}}</td>
      <td>{{$user->gender}}</td>
      <td>{{$user->image_url}}</td>
      <td>
        <a href="/users/{{$user->id}}/edit">Edit</a>
        <form action="/users/{{$user->id}}" method="POST">
        @method('delete')
        @csrf
          <input type="submit" value="Delete">
        </form>
      </td>
    </tr>
    @endforeach
  </tbody>
</table>