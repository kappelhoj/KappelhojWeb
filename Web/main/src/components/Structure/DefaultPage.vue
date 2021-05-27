<template>
  <div class="page">
    <div class="header">
      <NavBar/>
    </div>
    <div class="main">
      <slot></slot>
    </div>
  </div>
</template>

<script>
import NavBar from '../../components/Structure/Navigation/NavBar.vue'

export default {
  name: 'DefaultPage',
    components: {
    NavBar
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .page{
    display: grid;
    grid-template-columns: minmax(10px,auto) minmax(0,1280px) minmax(10px,auto);
    grid-template-rows: 3em auto;
    grid-template-areas: 
    " . header ."
    ". main .";
    text-align: center;
    color: var(--main-text-color);
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
  }

  .header{
    grid-area: header;
  }

  .main{
    grid-area: main;
  }
</style>
