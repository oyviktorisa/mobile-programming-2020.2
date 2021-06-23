<h1>Edit User</h1>

<form action="/users/{{$user->id}}" method="POST">
  @method('PUT')
  @csrf
  <input type="text" name="name" autocomplete="off" placeholder="name" value="{{$user->name}}"><br>
  <input type="text" name="username" autocomplete="off" placeholder="username" value="{{$user->username}}"><br>
  <input type="text" name="email" autocomplete="off" placeholder="email" value="{{$user->email}}"><br>
  <input type="text" name="password" autocomplete="off" placeholder="password" value="{{$user->password}}"><br>
  <input type="text" name="phone_number" autocomplete="off" placeholder="phone number" value="{{$user->phone_number}}"><br>
  <input type="text" name="gender" autocomplete="off" placeholder="gender" value="{{$user->gender}}"><br>
  <input type="text" name="image_url" autocomplete="off" placeholder="image url" value="{{$user->image_url}}"><br>
  <input type="submit" value="save">
</form>