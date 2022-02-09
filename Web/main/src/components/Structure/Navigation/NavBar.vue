<template>
  <div class="nav-bar">
    <NavItem title="Home" path="/"/>
    <NavItem title="Dev" path="/dev" />
    <NavItem title="Games" path="/games" />
  </div>
</template>


<script>
import NavItem from "../../Structure/Navigation/NavItem"
export default{
  name: 'NavBar',
  components:{
    NavItem
  }
}
</script>


<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .nav-bar{
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: flex-end;
  }
</style>
