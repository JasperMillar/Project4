<?php

use App\Http\Controllers\PizzaController;
use App\Http\Controllers\WinkelmandjeController;
use App\Models\Winkelmandje;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', [PizzaController::class, 'index']);
Route::resource('Home', PizzaController::class);
Route::resource('Winkelmandje', WinkelmandjeController::class);
