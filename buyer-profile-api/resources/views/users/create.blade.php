<h1>Create User</h1>

<form action="/users" method="POST">
  @csrf
  <input type="text" name="name" autocomplete="off" placeholder="name"><br>
  <input type="text" name="username" autocomplete="off" placeholder="username"><br>
  <input type="text" name="email" autocomplete="off" placeholder="email"><br>
  <input type="text" name="password" autocomplete="off" placeholder="password"><br>
  <input type="text" name="phone_number" autocomplete="off" placeholder="phone number"><br>
  <input type="text" name="gender" autocomplete="off" placeholder="gender"><br>
  <input type="text" name="image_url" autocomplete="off" placeholder="image url"><br>
  <input type="submit" value="save">
</form>