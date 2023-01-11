<?php

namespace App\Http\Controllers;

use App\Models\Bestellen;
use Illuminate\Http\Request;

class BestellenController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return view('Bestellen.index');
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        //
    }

    /**
     * Display the specified resource.
     *
     * @param  \App\Models\Bestellen  $bestellen
     * @return \Illuminate\Http\Response
     */
    public function show(Bestellen $bestellen)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  \App\Models\Bestellen  $bestellen
     * @return \Illuminate\Http\Response
     */
    public function edit(Bestellen $bestellen)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  \App\Models\Bestellen  $bestellen
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, Bestellen $bestellen)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  \App\Models\Bestellen  $bestellen
     * @return \Illuminate\Http\Response
     */
    public function destroy(Bestellen $bestellen)
    {
        //
    }
}
