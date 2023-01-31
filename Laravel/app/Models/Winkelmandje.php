<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Winkelmandje extends Model
{
    use HasFactory;

    protected $fillable = [
        'id',
        'pizzasoort',
        'toppings',
        'prijs',
        'groote',
    ];
}
