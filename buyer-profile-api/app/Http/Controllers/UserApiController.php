<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;

class UserApiController extends Controller
{
    public function index() {
        $users = User::all();
        return response()->json(['message' => 'Success', 'data' => $users]);
    }

    public function show($id) {
        $user = User::find($id);
        return response()->json(['message' => 'Success', 'data' => $user]);
    }

    public function store(Request $request) {
        $user = User::create($request->all());
        return response()->json(['message' => 'Data has been inserted successfully', 'data' => $user]);
    }

    public function update(Request $request, $id) {
        $user = User::find($id);
        $user->update($request->all());
        return response()->json(['message' => 'Data has been updated successfully', 'data' => $user]);
    }

    public function destroy($id) {
        $user = User::find($id);
        $user->delete();
        return response()->json(['message' => 'Data has been deleted successfully', 'data' => null]);
    }
}
