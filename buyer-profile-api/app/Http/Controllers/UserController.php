<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;

class UserController extends Controller
{
    public function index() {
        $users = User::all();
        // dd($users);
        return view('users.index', compact(['users']));
    }

    public function create() {
        return view('users.create');
    }

    public function store(Request $request) {
        User::create($request->all());
        return redirect('/users');
    }

    public function edit($id) {
        $user = User::find($id);
        return view('users.edit', compact(['user']));
    }

    public function update(Request $request, $id) {
        $user = User::find($id);
        $user->update($request->all());
        return redirect('/users');
    }

    public function destroy($id) {
        $user = User::find($id);
        $user->delete();
        return redirect('/users');
    }
}
