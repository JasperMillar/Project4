<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('winkelmandjes', function (Blueprint $table) {
            $table->id();
            $table->string('pizzasoort');
            $table->string('toppings');
            $table->decimal('prijs');
            $table->decimal('groote');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('winkelmandjes');
    }
};
