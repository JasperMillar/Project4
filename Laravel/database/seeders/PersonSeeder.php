<?php

namespace Database\Seeders;

use App\Models\Person;
use App\Models\User;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Spatie\Permission\Models\Permission;
use Spatie\Permission\Models\Role;

class PersonSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        // Create a user with role admin
        // admin
        $role = Role::create(['name' => 'admin']);
        $permission = Permission::create(['name' => 'admin']);
        $role->givePermissionTo($permission);
        $first = "admin";
        $last = "";
        $email = "admin@localhost";
        $user = User::factory(['name' => $first, 'email' => $email])->create();
        $user->assignRole('admin');
    }
}
